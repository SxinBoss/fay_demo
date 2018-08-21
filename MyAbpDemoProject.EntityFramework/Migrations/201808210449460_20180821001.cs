namespace MyAbpDemoProject.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;

    public partial class _20180821001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyMenus",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    Name = c.String(nullable: false, maxLength: 32),
                    Description = c.String(maxLength: 512),
                    Price = c.String(),
                    IsActive = c.Boolean(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                    LastModificationTime = c.DateTime(),
                    LastModifierUserId = c.Long(),
                    CreationTime = c.DateTime(nullable: false),
                    CreatorUserId = c.Long(),
                },
                annotations: new Dictionary<string, object>
                {
                    {
                        "DynamicFilter_Menus_SoftDelete",
                       "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.MyMenus",
            removedAnnotations: new Dictionary<string, object>
            {
                { "DynamicFilter_Menus_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
            });
        }
    }
}
