using AutoMapper;
using Data.FormModels;
using EMS.Constants;
using EMS.Data;
using EMS.Data.Entities.Emp;
using EMS.Data.FormModels.EmpSalary;
using EMS.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ems1.Controllers
{
    public class AmountController : Controller
    {
        private readonly IAmountService _amountService;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<Employee> _userManager;
        private EmpDbContext _applicationDbContext;

        public AmountController(IAmountService amountService, IEmailSender emailSender, IMapper mapper, UserManager<Employee> userManager, EmpDbContext applicationDbContext)
        {
            _amountService = amountService;
            _emailSender = emailSender;
            _mapper = mapper;
            _userManager = userManager;
            _applicationDbContext = applicationDbContext;
        }

        [Authorize(Roles = "Superadmin")]
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var users = await _userManager.GetUsersInRoleAsync(UserRoles.Employee);
            var list = users.Select(x => new SelectListItem { Text = x.UserName, Value = x.Id }).ToList();
            ViewBag.Employee = list;
            return View();
        }

        // POST: Amount/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmpSalaryVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                string employeeId = _userManager.GetUserId(User);
                var users = await _userManager.GetUsersInRoleAsync(UserRoles.Employee);
                SelectList list = new SelectList(users);
                ViewBag.Employee = list;

                if (model is not null && !string.IsNullOrEmpty(model.RequestingEmpId))
                {
                    if (_amountService.IsSalaryForEmployeeExist(model.RequestingEmpId, DateTime.Now.Month))
                    {
                        ModelState.AddModelError("", "Employee Salary already Credited...");
                        return View(model);
                    }
                    else
                    {
                        var emp = await _userManager.FindByIdAsync(model.RequestingEmpId);
                        EmpSalaryVM amountreqmodel = new EmpSalaryVM
                        {
                            RequestingEmpId = model.RequestingEmpId,
                            SalaryAmount = model.SalaryAmount,
                            Designation = model.Designation,
                            Department = model.Department,
                            GrossSalary = model.GrossSalary,
                            TotalWorkingDays = model.TotalWorkingDays,
                            PaidDays = model.PaidDays,
                            LOPDays = model.LOPDays,
                            BankName = model.BankName,
                            AccountNumber = model.AccountNumber,
                            HRA = model.HRA,
                            NetSalary = model.NetSalary,
                            ConveyanceAllowance = model.ConveyanceAllowance,
                            MedicalAllowance = model.MedicalAllowance,
                            EPF = model.EPF,
                            ProfessionalTax = model.ProfessionalTax,
                            Salarydate = DateTime.Now,
                            CreatedbyId = employeeId
                        };

                        EmpSalary amountRequest = _mapper.Map<EmpSalary>(amountreqmodel);
                        amountRequest.CreatedBy = _userManager.GetUserName(User);
                        await _amountService.AddEmployeeSalary(amountRequest);

                        // Send Email to supervisor and requesting user
                        await _emailSender.SendEmailAsync("admin@localhost.com", "New Leave Request",
                            $"Please review this leave request. <a href='UrlOfApp/{amountRequest.Id}'>Click Here</a>");

                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(model);
                }
                
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Something went wrong", ex.Message);
                return View(model);
            }
        }

        [Authorize(Roles = "Employee")]
        [HttpGet]
        public async Task<ActionResult> EmpIndex()
        {
            string employeeid = _userManager.GetUserId(User);      
            var employeeRequests = await _amountService.GetSalaryForEmployee(employeeid);
            foreach (var empSalary in employeeRequests)
            {
                var users = await _userManager.GetUsersInRoleAsync(UserRoles.Employee);
                empSalary.RequestingEmployee = users.Where(x => x.Id == empSalary.RequestingEmpId).FirstOrDefault();
            }

            List<EmpSalaryVM> employeeRequestsModel = _mapper.Map<List<EmpSalaryVM>>(employeeRequests);
            EmployeeDataVm model = new EmployeeDataVm
            {
                AmountVMs = employeeRequestsModel,
            };

            return View(model);
        }

        [Authorize(Roles = "Superadmin")]
        public async Task<ActionResult> Index()
        {
            List<EmpSalary> empSalaries = _amountService.FindAll();
            foreach (var empSalary in empSalaries)
            {
                if(empSalary.RequestingEmployee is null && !string.IsNullOrEmpty(empSalary.RequestingEmpId))
                {
                    var users = await _userManager.GetUsersInRoleAsync(UserRoles.Employee);
                    empSalary.RequestingEmployee = users.Where(x => x.Id == empSalary.RequestingEmpId).FirstOrDefault();
                }
            }
            List<EmpSalaryVM> empSalaryVM = _mapper.Map<List<EmpSalaryVM>>(empSalaries);
            AmountRequestVM model = new AmountRequestVM
            {
                Amounts = empSalaryVM
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                EmpSalary empSalary = await _amountService.GetEmpSalary(id);
                if (empSalary == null)
                {
                    return NotFound();
                }

                await _amountService.RemoveEmpSalary(empSalary.Id);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

    }
}

