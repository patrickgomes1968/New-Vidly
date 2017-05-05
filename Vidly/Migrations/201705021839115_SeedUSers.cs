namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUSers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'12d63cdd-8bd2-45c8-be2d-2461b707c8d6', N'guest@vidly.com', 0, N'AGLwUxT8V3OlOEI11TnP2ri00IoAMslMc/zipoHjwg2ywzSGDonNzY3YA1cBfxLRtw==', N'7870a05f-0280-4cc8-99ff-b7b0a75c14d5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'58b6d44a-825f-4a59-85d3-99e3ffdd91ce', N'admin@vidly.com', 0, N'AHUyyIH0QnX5Uykff196xYm7WTW2jeDLGN5CFUO+AK5OTFuQMUQc0SJfZngfnSKUjg==', N'0f9a712c-7bae-4354-ab93-45b6bd345800', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b0844c4b-9560-4081-8581-973aeab0d155', N'patrickgomes@gmail.com', 0, N'AIh1OO+T1FaCpfJ9jxjEPtYpQad4GA2ahUsi8jIqJh37/CsDk2NhkQ0dN1eGFN4Dkw==', N'9800683d-daf0-4bc0-8ae6-89f713d49ddc', NULL, 0, 0, NULL, 1, 0, N'patrickgomes@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'03ce5c74-5932-44ca-8383-5b876700e1d2', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'58b6d44a-825f-4a59-85d3-99e3ffdd91ce', N'03ce5c74-5932-44ca-8383-5b876700e1d2')

");
        }
        
        public override void Down()
        {
        }
    }
}
