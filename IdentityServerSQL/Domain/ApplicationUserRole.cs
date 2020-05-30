﻿using System;

namespace IdentityServerSQL.Models
{
    public class ApplicationUserRole
    {

        public ApplicationUserRole()
        {
            
        }   
        public ApplicationUserRole(ApplicationUser userId, ApplicationRole roleId)
        {
            ApplicationUser = userId;
            ApplicationRole = roleId;
            ApplicationUserId = userId.ApplicationUserId;
            ApplicationRoleId = roleId.ApplicationRoleId;
        }
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
        public Guid ApplicationRoleId { get; set; }
        public ApplicationRole ApplicationRole { get; set; }
       
       
    }
}