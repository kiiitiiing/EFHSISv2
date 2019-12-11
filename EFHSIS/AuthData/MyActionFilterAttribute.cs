using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;

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
            dictionary.Add("/","");
            dictionary.Add("/Home/ChildCare","");
            dictionary.Add("/DentalHealth/DentalHome","");
            dictionary.Add("/EnvironmentalHealth/EnvironmentalHome", "");
            dictionary.Add("/FamilyPlanning/FamilyHome", "");
            dictionary.Add("/Filariasis/FilariasisHome", "");
            dictionary.Add("/Leprosy/LeprosyHome", "");
            dictionary.Add("/Malaria/MalariaHome", "");
            dictionary.Add("/MaternalCare/MaternalHome","");
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
        }

    }
}
