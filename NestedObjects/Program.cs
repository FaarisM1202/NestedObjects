using NestedObjects;


using NestedObjects
Advisor compSciAdvisor = new();
{
    Email = "randomemail123@gmail.com",
    FullName = "John Smith",
    OfficeLocation = "B17 Rm 150"
};

Student stu1 = new();
{
    FirstName = "Jimmy",
    LastName = "Neutron",
    DateOfBirth = new DateTime(1999, 5, 14),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "12345678912",
    SchoolEmail = "jimmy.neutron123@gmail.com"
};
Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");