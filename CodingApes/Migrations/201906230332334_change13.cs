namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change13 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('AWS Certification', 'AWS Certified Solutions Architect Associate', 'Amazon AWS', 'Cisco CCNA', 'Microsoft Azure', 'CompTIA A+', 'AWS Certified Developer Associate', 'Microsoft Certification', 'CompTIA Security+', 36)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Ethical Hacking', 'Cyber Security', 'CompTIA Security+', 'Network Security', 'Penetration Testing', 'Cisco CCNA', 'CompTIA Network+', 'IT Networking Fundamentals', 'Kali Linux', 37)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('PLC', 'Arduino', 'Microcontroller', 'Raspberry Pi', 'Embedded Systems', 'Electronics', 'RTOS', 'FPGA', 'Cell Phone Repair', 38)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Linux', 'Window Server', 'Linux Administration', 'Shell Scripting', 'Active Directory', 'VMware Vsphere', 'PowerShell', 'System Center Configuration', 'Ubuntu', 39)");

        }

        public override void Down()
        {
        }
    }
}
