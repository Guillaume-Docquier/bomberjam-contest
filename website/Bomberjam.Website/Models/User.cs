﻿using System;

namespace Bomberjam.Website.Models
{
    public class User : SelectableUser
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int GithubId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public float Points { get; set; }
        public int AllBotCount { get; set; }
        public int CompiledBotCount { get; set; }
    }
}