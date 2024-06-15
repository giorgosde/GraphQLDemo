
# GraphQL Demo

GraphQL demo - cheatsheet using .NET 9 and [Hot Chocolate](https://chillicream.com/docs/hotchocolate/v13)

#### Page
`https://localhost:XXXX/graphql/`

#### Basic Query
```
query {
  book {
    title
    author {
      name
    }
  }
}
```


#### Alias Query
```
query {
  books: book {
    title
  }
  authors: book {
    author {
      name
    }
  }
}
```