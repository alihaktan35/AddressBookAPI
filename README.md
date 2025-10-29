# Address Book REST API

A simple REST API for managing contacts in an address book.

**Course Assignment:** SE4458 - Software Engineering  
**University:** Yaşar University  
**Date:** October 2025

---

## About This Project

This is a web API that helps you manage an address book. You can add, view, update, and delete contacts. You can also search for contacts by name, email, or category.

## What Can It Do?

- ➕ Add new contacts
- 📋 See all contacts
- 🔍 Find a contact by ID
- ✏️ Update contact information
- 🗑️ Delete contacts
- 🔎 Search contacts by name, email, or category

## Technology

This project uses:
- .NET 9.0 Web API
- Swagger/OpenAPI (for testing and documentation)
- In-Memory Database (data is stored while the app runs)
- REST API design

## How to Use the API

### Available Endpoints

| Method | Endpoint | What It Does |
|--------|----------|-------------|
| GET | `/api/contacts` | Get all contacts |
| GET | `/api/contacts/{id}` | Get one contact by ID |
| POST | `/api/contacts` | Create a new contact |
| PUT | `/api/contacts/{id}` | Update a contact |
| DELETE | `/api/contacts/{id}` | Delete a contact |
| GET | `/api/contacts/search?query={query}` | Search for contacts |

### Example: Create a New Contact

**Request:**
```json
POST /api/contacts
{
  "firstName": "Ahmet",
  "lastName": "Yılmaz",
  "email": "ahmet@example.com",
  "phone": "05551234567",
  "address": "İzmir, Türkiye",
  "category": "Work"
}
```

**Response:**
```json
{
  "id": 1,
  "firstName": "Ahmet",
  "lastName": "Yılmaz",
  "email": "ahmet@example.com",
  "phone": "05551234567",
  "address": "İzmir, Türkiye",
  "category": "Work",
  "createdAt": "2025-10-26T12:00:00Z"
}
```

## Try It Online

🔗 **API Link:** https://addressbook-ahs.azurewebsites.net  
📚 **API Documentation:** https://addressbook-ahs.azurewebsites.net/swagger/index.html

The API is running on Azure App Service. You can test it using the Swagger interface.

## Run It on Your Computer

### What You Need

- .NET 9.0 SDK
- Git

### Steps to Install

1. **Download the project:**
```bash
git clone https://github.com/alihaktan35/AddressBookAPI.git
cd AddressBookAPI
```

2. **Start the application:**
```bash
dotnet run
```

3. **Open the API documentation:**
```
http://localhost:5192/swagger
```

Now you can test the API on your computer!

## Project Structure

```
AddressBookAPI/
├── Controllers/
│   └── ContactsController.cs    # API endpoints
├── Data/
│   └── ContactDatabase.cs       # Data storage
├── Models/
│   └── Contact.cs               # Contact information structure
├── Program.cs                   # App settings
└── README.md                    # This file
```

## Design Choices

**In-Memory Storage**  
We use in-memory storage for this project. This means the data is simple to work with, but it will be deleted when you stop the application.

**REST Design**  
The API follows REST standards:
- Uses correct HTTP methods (GET, POST, PUT, DELETE)
- Returns proper status codes (200, 201, 204, 404)
- Uses clear, resource-based URLs

**Search Feature**  
You can search contacts by first name, last name, email, or category.

**CORS**  
CORS is enabled so a frontend application can connect to this API in the future.

**Swagger**  
Swagger creates automatic documentation and provides a testing interface for the API.

## Problems We Solved

**Problem 1: Swagger Not Working**  
- Issue: Swagger was not installed at first
- Solution: We added the `Swashbuckle.AspNetCore` package

**Problem 2: HTTPS Warning**  
- Issue: HTTPS settings caused warnings during development
- Solution: We use HTTP for local testing and HTTPS for production

**Problem 3: 404 Error on Home Page**  
- Issue: The main URL showed a 404 error
- Solution: We set Swagger as the default page and fixed the endpoint settings

## What I Learned

- How to design REST APIs
- How to use .NET Web API
- How to manage data in memory
- How to create API documentation with Swagger
- How to use Git for version control
- How to prepare for cloud deployment

## License

This project is for educational purposes only (SE4458 Course Assignment).

---

**Course:** SE4458 - Software Engineering  
**Institution:** Yaşar University  
**Date:** October 2025
