
namespace P0;

class Gunpla
{
    public string name {get; set;}
    public string desc {get; set;}
    public string grade {get; set;}
    public string type {get; set;}
    public string status {get; set;}

    public Gunpla()
    {
        
    }
    public Gunpla(string n, string d, string g, string t, string s)
    {
        name = n;
        desc = d;
        grade = g;
        type = t;
        status = s;
    }

    public override string ToString()
    {
        return $"Name: {name}\nGrade: {grade}\nType: {type}\nDescription: {desc}\nStatus: {status}";
    }
  
}