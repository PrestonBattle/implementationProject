using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ThriveHavenMovies.Models.AccountStuff;

public class PreferencesController : Controller
{
    private readonly IPaymentRepository _paymentRepository;
    private readonly UserManager<Users> _userManager;

    public PreferencesController(IPaymentRepository paymentRepository, UserManager<Users> userManager)
    {
        _paymentRepository = paymentRepository;
        _userManager = userManager;
    }

    public async Task<IActionResult> Preferences()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Login", "Account");

        var payments = _paymentRepository.GetPaymentsByUser(user.Id);
        return View(payments);
    }

    [HttpPost]
    public async Task<IActionResult> SavePayment(Payment payment)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Login", "Account");

        payment.UserId = user.Id;

        if (payment.IsDefault)
        {
            var existingDefault = _paymentRepository.GetDefaultPayment(user.Id);
            if (existingDefault != null)
            {
                existingDefault.IsDefault = false;
                _paymentRepository.Update(existingDefault);
            }
        }

        _paymentRepository.Add(payment);
        return RedirectToAction("Preferences");
    }

    [HttpPost]

    public async Task<IActionResult> DeletePayment(Payment payment)
    {
        var user = await _userManager.GetUserAsync (User);
        if (user == null) return RedirectToAction("Login", "Account");

        _paymentRepository.Delete(payment);
        return RedirectToAction("Preferences");
    }

    [HttpPost]
    public async Task<IActionResult>EditPayment(Payment payment)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Login", "Account");

        _paymentRepository.Update(payment);
        return RedirectToAction("Preferences");
    }
}
