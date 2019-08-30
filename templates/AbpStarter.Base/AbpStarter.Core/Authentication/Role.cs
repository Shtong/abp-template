namespace AbpStarter.Core.Authentication
{
    using Abp.Authorization.Roles;

    /// <summary>
    /// This represents a role known in the application.
    /// </summary>
    /// <remarks>
    /// All users may be assigned to one or more roles.
    /// Roles are usually assigned at least one permission.
    /// We can then consider that a user can access all permissions assigned
    /// to his or her roles.
    /// </remarks>
    public class Role : AbpRole<User>
    {
        /// <summary>
        /// Creates a new instance of <see cref="Role"/>, with a random name, and not attached to a tenant.
        /// </summary>
        public Role()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="Role"/>, with a random name, and the spacified tenant and display name.
        /// </summary>
        /// <param name="tenantId">A tenant ID, or <see langword="null"/> to create a host level role.</param>
        /// <param name="displayName">The display name to be used for the new role.</param>
        public Role(int? tenantId, string displayName) 
            : base(tenantId, displayName)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="Role"/>.
        /// </summary>
        /// <param name="tenantId">A tenant ID, or <see langword="null"/> to create a host level role.</param>
        /// <param name="name">The name of the role. Role names should be unique among their tenant.</param>
        /// <param name="displayName">The display name to be used for the new role.</param>
        public Role(int? tenantId, string name, string displayName)
            : base(tenantId, name, displayName)
        {
        }
    }
}
