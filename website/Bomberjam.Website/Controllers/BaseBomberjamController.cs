﻿using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Bomberjam.Website.Database;
using Bomberjam.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;

namespace Bomberjam.Website.Controllers
{
    public class BaseBomberjamController<T> : Controller
        where T : Controller
    {
        public BaseBomberjamController(IRepository repository, ILogger<T> logger)
        {
            this.Repository = repository;
            this.Logger = logger;
        }

        protected IRepository Repository { get; }

        protected ILogger<T> Logger { get; }

        protected Task<User> GetAuthenticatedUser()
        {
            if (!this.TryGetNameIdentifierClaim(out var githubId))
            {
                throw new Exception("TODO Not authenticated");
            }

            return this.Repository.GetUserByGithubId(githubId);
        }

        protected bool TryGetNameIdentifierClaim(out int nameIdentifier)
        {
            var nameIdentifierClaim = this.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            if (nameIdentifierClaim != null && int.TryParse(nameIdentifierClaim.Value, out nameIdentifier))
            {
                return true;
            }

            nameIdentifier = -1;
            return false;
        }

        protected static string[] GetAllErrors(ModelStateDictionary modelState)
        {
            return modelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToArray();
        }
    }
}