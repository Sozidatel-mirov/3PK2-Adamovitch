using P3_8;

ContactBook phoneBook = new ContactBook();

phoneBook.AddContact("Man", "Жека друг", "8-800-555-35-35", "Нехороший");
phoneBook.AddContact("Organization", "ООО 'Дракон'", "8-3532-232-35-35", "5335333444");
phoneBook.AddContact("Hotel", "Сказка", "8-3532-555-32-35", "Салмышская, 32");

phoneBook.ShowContacts();