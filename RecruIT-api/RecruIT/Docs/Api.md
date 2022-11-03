# RecruIT API

- [RecruIT API](#recruit-api)
    - [Candidate](#candidate)
        - [Create Candidate](#create-candidate)
            - [Create Candidate Request](#create-candidate-request)
            - [Create Candidate Response](#create-candidate-response)
        - [Get Candidate](#get-candidate)
            - [Get Candidate Request](#get-candidate-request)
            - [Get Candidate Response](#get-candidate-response)
        - [Update Candidate](#update-candidate)
            - [Update Candidate Request](#update-candidate-request)
            - [Update Candidate Response](#update-candidate-response)
        - [Delete Candidate](#delete-candidate)
            - [Delete Candidate Request](#delete-candidate-request)
            - [Delete Candidate Response](#delete-candidate-response)

# Candidate
## Create Candidate

### Create Candidate Request

```js
POST /candidates
```

```json
{
    "name": "Gabriel Torres",
    "cpf": 54322582001,
    "age": 22,
    "email": "atorres.gabriel@gmail.com",
    "bio": "Hi, I'm Gabriel Torres, and I graduated from the University of New Mexico in 2015 with a degree in Computer Science. My interests are in Front End Engineering, and I love to create beautiful and performant products with delightful user experiences",
    "skills": {
        "Python": 2,
        "Angular": 2,
        "C#": 0,
        ".NET": 3
    },
    "links": [
        "github.com/gabriel-torres3077",
        "linkedin.com/in/gabriel-a-torres/"
    ]
}
```

### Create Candidate Response

```js
201 Created
```

```yml
Location: {{host}}/Candidates/{{id}}
```

```json
{
    "id": 0,
    "name": "Gabriel Torres",
    "cpf": 54322582001,
    "age": 22,
    "email": "atorres.gabriel@gmail.com",
    "bio": "Hi, I'm Gabriel Torres, and I graduated from the University of New Mexico in 2015 with a degree in Computer Science. My interests are in Front End Engineering, and I love to create beautiful and performant products with delightful user experiences",
    "skills": {
        "Python": 2,
        "Angular": 2,
        "C#": 0,
        ".NET": 3
    },
    "links": [
        "github.com/gabriel-torres3077",
        "linkedin.com/in/gabriel-a-torres/"
    ]
}
```

## Get Candidate

### Get Candidate Request

```js
GET /candidates/{{id}}
```

### Get Candidate Response

```js
200 Ok
```

```json
{
    "id": 0,
    "name": "Gabriel Torres",
    "cpf": 54322582001,
    "age": 22,
    "email": "atorres.gabriel@gmail.com",
    "bio": "Hi, I'm Gabriel Torres, and I graduated from the University of New Mexico in 2015 with a degree in Computer Science. My interests are in Front End Engineering, and I love to create beautiful and performant products with delightful user experiences",
    "skills": {
        "Python": 2,
        "Angular": 2,
        "C#": 0,
        ".NET": 3
    },
    "links": [
        "github.com/gabriel-torres3077",
        "linkedin.com/in/gabriel-a-torres/"
    ]
}
```

## Update Candidate

### Update Candidate Request

```js
PUT /candidates/{{id}}
```

```json
{
    "name": "Gabriel Torres",
    "cpf": 54322582001,
    "age": 22,
    "email": "atorres.gabriel@gmail.com",
    "bio": "Hi, I'm Gabriel Torres, and I graduated from the University of New Mexico in 2015 with a degree in Computer Science. My interests are in Front End Engineering, and I love to create beautiful and performant products with delightful user experiences",
    "skills": {
        "Python": 2,
        "Angular": 2,
        "C#": 0,
        ".NET": 3
    },
    "links": [
        "github.com/gabriel-torres3077",
        "linkedin.com/in/gabriel-a-torres/"
    ]
}
```

### Update Candidate Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Candidates/{{id}}
```

## Delete Candidate

### Delete Candidate Request

```js
DELETE /candidates/{{id}}
```

### Delete Candidate Response

```js
204 No Content
```