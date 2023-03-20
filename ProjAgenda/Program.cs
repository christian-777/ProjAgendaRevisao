using ProjAgenda;

List<Contact> phonebook = new List<Contact>();

int op;
do
{
    op = Menu();
    switch (op)
    {
        case 1:
            phonebook.Add(CreateContact());
            break;

        case 2:
            EditItem();
            break;

        case 3:
            phonebook.Remove(DeleteContact());
            break;

        case 4:
            PrintPhoneBook(phonebook);
            break;

        case 5:
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
} while (true);

void EditItem()
{
    Console.WriteLine("Informe o nome: ");
    var n = Console.ReadLine();
    int i = 0;
    string aux;

    foreach (var item in phonebook)
    {
        if (item.Name.Equals(n))
        {
            Console.WriteLine("Novo numero de telefone: ");
            item.EditPhone(Console.ReadLine());
            return;
        }
        i++;
    }
}

Contact DeleteContact()
{
    Console.WriteLine("Informe o nome: ");
    var n = Console.ReadLine();
    foreach (var item in phonebook)
    {
        if(item.Name.Equals(n))
        {
            return item;
        }
    }
    return null;
}

Contact CreateContact()
{
    Console.WriteLine("Informe o nome: ");
    string n = Console.ReadLine();
    Console.WriteLine("Informe o telefone: ");
    var t = Console.ReadLine();
    Contact contact = new(n, t);

    return contact;
}


//Contact contact = new Contact("Felipe", "16 99629.3392");
//contact.Address.EditStreet("Rua Nove de Julho, 2100");
//contact.Address.EditPostalCode("14.802-130");
//contact.Address.EditState("SP");
//contact.Address.EditCity("Araraquara");
//contact.Address.EditCountry("Brasil");

//Contact contact2 = new Contact("Sheldon", "99 99999.9999");
//contact2.Address.EditStreet("Rua do Sheldon, 99");
//contact2.Address.EditPostalCode("91.001-000");
//contact2.Address.EditState("CA");
//contact2.Address.EditCity("Pasadena");
//contact2.Address.EditCountry("EUA");

//phonebook.Add(contact2);
//phonebook.Add(contact);

//PrintPhoneBook(phonebook);

//phonebook.Remove(contact);

//PrintPhoneBook(phonebook);

void PrintPhoneBook(List<Contact> l)
{
    foreach (var item in l)
    {
        Console.WriteLine(item);
    }
}

int Menu()
{
    Console.WriteLine("MENU DE OPÇOES\n1 - Insere Contato" +
        "\n2 - Editar Contato\n3 - Remover Contato\n4- Mostrar Agenda\n5 - Sair\n\nEscolha uma opção: ");
    var xpto = int.Parse(Console.ReadLine());

    return xpto;
}