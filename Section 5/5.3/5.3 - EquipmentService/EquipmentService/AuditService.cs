using System.IO;

namespace EquipmentService
{
    public class AuditService
    {
        public string Path = "auditLog.txt";

        public void WriteEmploeeInformation(Employee employee)
        {
            using (StreamWriter writer = File.AppendText(Path))
            {
                writer.WriteLine($"Employ {employee.EmployeeId} has a bundle with {employee.Bundle.Items.Count} bundles.");
            }
        }
    }
}
