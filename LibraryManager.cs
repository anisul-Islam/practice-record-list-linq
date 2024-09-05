public record Member(string Name, int Age);


public class LibraryManager
{
    static List<Member> memberItems = new List<Member>(); // Make this static

    public static List<Member> GetMembers()
    {
        return memberItems;
    }

    public static void AddMember()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Add Member in the library ");
        Console.WriteLine($"=================================================");

        Console.WriteLine($"Please Add The Data Member:");

        Console.WriteLine($"Please Enter the Name: ");
        string memberName = Console.ReadLine();

        Console.WriteLine($"Please Enter Your Age: ");
        int memberAge = Convert.ToInt32(Console.ReadLine());

        var dataMember = new Member(memberName, memberAge);
        memberItems.Add(dataMember);
    }

    public static void DisplayMembers()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Display Members");
        Console.WriteLine($"=================================================");

        foreach (var member in memberItems)
        {
            Console.WriteLine($"Member Name: {member.Name} // Member Age: {member.Age} ");
        }
    }

    private static void RemoveMember(string memberName)
    {
        var removeMember = memberItems.FirstOrDefault(memberItems => memberItems.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase));

        if (removeMember != null)
        {
            memberItems.Remove(removeMember);
            Console.WriteLine($"{memberName} has been removed.");
        }
        else
        {
            Console.WriteLine($"The book '{memberName}' that you searched for does not exist.");
        }
    }

    public static void RemovingMember()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Remove Member ");
        Console.WriteLine($"=================================================");

        Console.WriteLine($"Please Enter the Name of the member:");
        string memberName = Console.ReadLine();
        RemoveMember(memberName);
    }

    private static void SearchMemberName(string memberName)
    {
        var memberInfo = memberItems.FirstOrDefault(memberItems => memberItems.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase));

        if (memberInfo != null)
        {
            Console.WriteLine($"{memberName} exists.");
            Console.WriteLine($"Book Information");
            Console.WriteLine($"Member Name: {memberInfo.Name}");
            Console.WriteLine($"Member Age: {memberInfo.Age}");
        }
        else
        {
            Console.WriteLine($"The book '{memberName}' you are looking for does not exist!");
        }
    }

    public static void SearchingMemberName()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Search Member ");
        Console.WriteLine($"=================================================");

        Console.WriteLine($"Please Enter the Name of the book:");
        string memberName = Console.ReadLine();

        SearchMemberName(memberName);
    }



}
