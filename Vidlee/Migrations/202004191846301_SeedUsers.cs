namespace Vidlee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'32bb1039-c21f-4f0c-a863-096c7887d929', N'admin@mail.com', 0, N'AFtGXKnyP6AGu2COmg69MJyJNHhwJzg/6t+iJwL1NoluBIpfFPEqhWUo4MbO9SqWZg==', N'0bd3d34c-8df8-4370-8b8f-3610589ba6e8', NULL, 0, 0, NULL, 1, 0, N'admin@mail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'777fb948-a2b5-40a8-8342-b7188de2e849', N'guest@mail.com', 0, N'AEKtOeXWFYpgBMAFPsS/ld5M4/Jqg+W24m4pLou8quEswBjfzaT5TH+7GO67f/fMfg==', N'b3a60b5e-6ad6-4bb2-beb8-9edfac02bed3', NULL, 0, 0, NULL, 1, 0, N'guest@mail.com')
            ");

            Sql(@"
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'32bb1039-c21f-4f0c-a863-096c7887d929', N'8e75c188-2ffb-429c-b9c7-eaa38efeef74')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
