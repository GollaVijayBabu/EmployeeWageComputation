using System;
namespace EmployeeWageComputation
{
    public interface IEmpWageBuilderUC_11
    {
        public void addCompany(string company, int empRatePerHr, int numWorkingDays, int maxHrsInMonth);
        public void ComputeEmpWage();
    }
}

