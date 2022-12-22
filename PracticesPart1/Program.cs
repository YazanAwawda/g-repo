class person { 
    public string ? FirstName { get; private set; }
    public string? LastName { get; private set; }

    public person(String firstName, String lastName) { 
    this.FirstName = firstName;
    this.LastName = lastName;
    }
    public virtual String GetFullName() {
        return String.Format("{0} {1}" , FirstName , LastName);
    }
}
// Child class fields should not hide parent class fields
class employee : person { 

    public String Role { get; private set; }

    public employee(String firstName, String lastName, String role) : base(firstName, firstName)
    {
        Role = role;
    }

    public override string GetFullName()
    {
        return base.GetFullName();
    }
}