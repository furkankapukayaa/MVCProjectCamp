namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class talentcard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TalentCards",
                c => new
                    {
                        CardId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        LastName = c.String(maxLength: 20),
                        Text = c.String(maxLength: 50),
                        Skill = c.String(maxLength: 20),
                        SkillPoint = c.Int(nullable: false),
                        Skill2 = c.String(maxLength: 20),
                        SkillPoint2 = c.Int(nullable: false),
                        Skill3 = c.String(maxLength: 20),
                        SkillPoint3 = c.Int(nullable: false),
                        Skill4 = c.String(maxLength: 20),
                        SkillPoint4 = c.Int(nullable: false),
                        Skill5 = c.String(maxLength: 20),
                        SkillPoint5 = c.Int(nullable: false),
                        Skill6 = c.String(maxLength: 20),
                        SkillPoint6 = c.Int(nullable: false),
                        Skill7 = c.String(maxLength: 20),
                        SkillPoint7 = c.Int(nullable: false),
                        Skill8 = c.String(maxLength: 20),
                        SkillPoint8 = c.Int(nullable: false),
                        Skill9 = c.String(maxLength: 20),
                        SkillPoint9 = c.Int(nullable: false),
                        Skill10 = c.String(maxLength: 20),
                        SkillPoint10 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CardId);
            
            CreateTable(
                "dbo.TalentCardSkills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        Skill = c.String(maxLength: 20),
                        SkillPoint = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.SkillId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TalentCardSkills");
            DropTable("dbo.TalentCards");
        }
    }
}
