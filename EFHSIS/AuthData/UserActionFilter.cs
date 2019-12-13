using EFHSIS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFHSIS.AuthData
{
    public class UserActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // our code before action executes
            var controller = context.Controller as Controller;
            //var url = context.HttpContext.Request.Path;
            //controller.ViewBag.NavCheck = NavBarFilter(url);
            //controller.ViewBag.user_province = ProvinceFilter();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // our code after action executes
            var controller = context.Controller as Controller;

            var session_obj = context.HttpContext.Session.GetString("SessionUser");
            if (session_obj == null)
                context.HttpContext.Response.Redirect("/logout");
            var user_info = JsonConvert.DeserializeObject<UserInfo>(session_obj);
            controller.ViewBag.user_info = user_info;
        }

        public object NavBarFilter(string url) {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add("/", "");
            dictionary.Add("/Home/ChildCare", "");
            dictionary.Add("/DentalHealth/DentalHome", "");
            dictionary.Add("/EnvironmentalHealth/EnvironmentalHome", "");
            dictionary.Add("/FamilyPlanning/FamilyHome", "");
            dictionary.Add("/Filariasis/FilariasisHome", "");
            dictionary.Add("/Leprosy/LeprosyHome", "");
            dictionary.Add("/Malaria/MalariaHome", "");
            dictionary.Add("/MaternalCare/MaternalHome", "");
            dictionary.Add("/MortBhs/MortBhsHome", "");
            dictionary.Add("/Mortality/MortalityHome", "");
            dictionary.Add("/Natality/NatalityHome", "");
            dictionary.Add("/NatalityLcr/NatalityLcrHome", "");
            dictionary.Add("/NatalityTcl/NatalityTclHome", "");
            dictionary.Add("/Schistosomiasis/SchistosomiasisHome", "");
            dictionary.Add("/Sti/StiHome", "");
            dictionary.Add("/Tuberculosis/TuberculosisHome", "");
            dictionary[url] = "active";
            return dictionary;
        }

        public object ProvinceFilter() {
            var user_province = new Dictionary<int, object>();
            user_province.Add(0, "SESSION EXPIRED");
            user_province.Add(1, "BOHOL");
            user_province.Add(2, "CEBU");
            user_province.Add(3, "NEGROS ORIENTAL");

            return user_province;
        }
    }
}
