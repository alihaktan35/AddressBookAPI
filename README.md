# Address Book REST API

SE4458 Assignment

## 📝 Project Description
A REST API application for managing an address book with full CRUD operations and search functionality.

## ✨ Features
- ➕ Create new contacts
- 📋 List all contacts
- 🔍 Get contact by ID
- ✏️ Update existing contacts
- 🗑️ Delete contacts
- 🔎 Search contacts by name, email, or category

## 🛠️ Technologies Used
- .NET 9.0 Web API
- Swagger/OpenAPI for API documentation
- In-Memory Database
- RESTful API design principles

## 📡 API Endpoints

### Contacts

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/contacts` | Get all contacts |
| GET | `/api/contacts/{id}` | Get contact by ID |
| POST | `/api/contacts` | Create new contact |
| PUT | `/api/contacts/{id}` | Update contact |
| DELETE | `/api/contacts/{id}` | Delete contact |
| GET | `/api/contacts/search?query={query}` | Search contacts |

### Example Request - Create Contact
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

### Example Response
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

## 🌐 Live Demo
🔗 **API URL:** [Will be added after deployment]
📚 **Swagger Documentation:** [Will be added after deployment]

## 💻 Local Development

### Prerequisites
- .NET 9.0 SDK or later
- Git

### Installation

1. Clone the repository:
```bash
git clone https://github.com/YOURUSERNAME/AddressBookAPI.git
cd AddressBookAPI
```

2. Run the application:
```bash
dotnet run
```

3. Open Swagger UI:
```
http://localhost:5192/swagger
```

## 🏗️ Project Structure
```
AddressBookAPI/
├── Controllers/
│   └── ContactsController.cs    # API endpoints
├── Data/
│   └── ContactDatabase.cs       # In-memory data storage
├── Models/
│   └── Contact.cs               # Contact model
├── Program.cs                   # Application configuration
└── README.md
```

## 🎯 Design Decisions

1. **In-Memory Storage**: Used for simplicity and quick development. Data resets when application restarts.

2. **RESTful Design**: Followed REST conventions:
   - Proper HTTP methods (GET, POST, PUT, DELETE)
   - Meaningful status codes (200, 201, 204, 404)
   - Resource-based URLs

3. **Search Functionality**: Implemented flexible search across multiple fields (firstName, lastName, email, category).

4. **CORS Policy**: Enabled to allow future frontend integration.

5. **Swagger Integration**: Automatic API documentation and testing interface.

## 🐛 Issues Encountered & Solutions

### Issue 1: Swagger Not Loading
**Problem:** Initial setup didn't include Swagger package.
**Solution:** Added `Swashbuckle.AspNetCore` NuGet package.

### Issue 2: HTTPS Redirect Warning
**Problem:** HTTPS port configuration caused warnings in development.
**Solution:** Kept HTTP endpoint for local development, will use HTTPS in production deployment.

### Issue 3: 404 Error on Root Path
**Problem:** Root URL returned 404.
**Solution:** Configured Swagger UI as default route and set proper endpoint configuration.

## 📚 What We Learned

- REST API design principles
- .NET Web API framework
- In-memory data management
- API documentation with Swagger
- Git version control and collaboration
- Cloud deployment preparation

## 🚀 Future Improvements

- [ ] Add database persistence (PostgreSQL or SQL Server)
- [ ] Implement authentication and authorization
- [ ] Add input validation
- [ ] Implement pagination for large datasets
- [ ] Add unit and integration tests
- [ ] Create a frontend application

## 📄 License
This project is for educational purposes (SE4458 Course Assignment).

## 🙏 Acknowledgments
- Thanks to our instructor for the guidance
- Microsoft ASP.NET Core documentation
- Swagger/OpenAPI specification

---

**Course:** SE4458 - Software Engineering  
**Institution:** Yaşar University  
**Date:** October 2025
