# Books API

This project is first homework that made for .NET Bootcamp.

Main goal is to create an API that can perform some operations on a book list.

Program has ``CREATE``, ``RETRIEVE``, ``UPDATE`` and ``DELETE`` functions on the list.

## How To Use

Simply run the project on localhost and use related link.

### Get All Books

Go to ``https://[localhost]:[port]/api/Books`` and send a POST request with a blank body.

### Get Book By Id Using Route

Go to ``https://[localhost]:[port]/api/Books/[bookId]`` Using GET method.

### Get Book By Id Using Query Parameter

Go to ``https://[localhost]:[port]/api/Books/?id=[bookId]`` Using GET method.

### Add Book

Go to ``https://[localhost]:[port]/api/Books/addBook`` and use POST method with a JSON in the body
```
{
  "id": 0,
  "kitapSeriNo": "string",
  "kitapAdi": "string",
  "yazari": "string",
  "sayfaSayisi": 0
}
```

### Update Book

Go to ``https://[localhost]:[port]/api/Books`` and use PUT method with a JSON in the body
```
{
  "id": 0,
  "kitapSeriNo": "string",
  "kitapAdi": "string",
  "yazari": "string",
  "sayfaSayisi": 0
}
```

### Delete Book By Id

Go to ``https://[localhost]:[port]/api/Books`` and use DELETE method with a ``id`` parameter in the body.










