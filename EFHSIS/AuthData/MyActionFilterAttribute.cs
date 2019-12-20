using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Newtonsoft.Json;
using EFHSIS.Models;
using System.Reflection;

namespace EFHSIS.AuthData
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await base.OnActionExecutionAsync(context, next);

            var controller = context.Controller as Controller;
            if (controller == null) return;

            var url = context.HttpContext.Request.Path;
            controller.ViewBag.ctrlurl = url;
            var dictionary = new Dictionary<string, object>();
            dictionary.Add("","");
            dictionary.Add("/ChildCare/ChildHome", "");
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
            controller.ViewBag.NavCheck = dictionary;
            var user_province = new Dictionary<int, object>();
            user_province.Add(0,"SESSION EXPIRED");
            user_province.Add(1,"BOHOL");
            user_province.Add(2,"CEBU");
            user_province.Add(3,"NEGROS ORIENTAL");
            controller.ViewBag.user_province = user_province;
            context.HttpContext.Session.SetString("province_id", "CEBU"); //temporary lang para dile ma error ang system

            var session_obj = context.HttpContext.Session.GetString("SessionUser");
            /*if (session_obj == null)
                context.HttpContext.Response.Redirect("/konsole/logout");*/


            var user_info = session_obj != null 
                ? 
                JsonConvert.DeserializeObject<UserInfo>(context.HttpContext.Session.GetString("SessionUser")) 
                : 
                new UserInfo()
                {
                    username = "Session Expired",
                    password = "Session Expired",
                    province_id = 0
                };

            controller.ViewBag.user_info = user_info;


        }

    }
}
