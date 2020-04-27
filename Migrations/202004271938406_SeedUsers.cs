namespace Retroly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'701d9320-1284-49ed-9933-60c6f81a034e', N'guest@retroly.com', 0, N'AEVq9wU1L2gxZmdMczDcTpAIa2O/vMHmPcmnwqpE65PTFR3bmu5KuKDkGH16nCY2pA==', N'e56596ba-7e5f-430a-91a8-dcaa2f8d10d4', NULL, 0, 0, NULL, 1, 0, N'guest@retroly.com')
                  INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'c8ebf4bf-36d0-4343-bc36-9abd1703f5fe', N'admin@retroly.com', 0, N'ACXDfMzk/da3SqV5i2AQ1IT2qaIxPo48kIzyKHlFVmTCogzGe18zjWJgp+9cpXD9xA==', N'45e5b92b-8a0b-44aa-8871-bdcc3633184d', NULL, 0, 0, NULL, 1, 0, N'admin@retroly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ad7026b2-6539-48fc-afbb-502e95804191', N'CanManageGames')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c8ebf4bf-36d0-4343-bc36-9abd1703f5fe', N'ad7026b2-6539-48fc-afbb-502e95804191')
                ");
        
        }

        
        public override void Down()
        {
        }
    }
}
