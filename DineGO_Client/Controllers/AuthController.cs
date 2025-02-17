using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Core.Common;
namespace DineGO_Client.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ApiService _apiService;
        public AuthController(ILogger<AuthController> logger, ApiService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Modified: Gọi apiService để thực hiện login từ API backend
            var loginData = new { Username = username, Password = password };
            
            // Giả sử endpoint trên API backend là "auth/login" và trả về token
            var response = await _apiService.PostAsync<LoginResponse, dynamic>("auth/login", loginData);

            if (response != null && !string.IsNullOrEmpty(response.token))
            {
                // Modified: Lưu token vào session để sử dụng cho các request sau
                HttpContext.Session.SetString("token", response.token);
                return RedirectToAction("Index", "Home");
            }

            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        public class LoginResponse
        {
            public string token { get; set; }
        }
    }
}