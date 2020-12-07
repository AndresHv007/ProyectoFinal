using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CalificacionesContext;
using CalificacionesContext.Models;
using System.ComponentModel.DataAnnotations;
using CalificacionesWeb.Helpers;

namespace CalificacionesWeb.Helpers
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
        }
    }
}