
# GraphQL Demo

GraphQL demo - cheatsheet using .NET 9 and [Hot Chocolate](https://chillicream.com/docs/hotchocolate/v13)

#### Page
`https://localhost:XXXX/graphql/`
`https://localhost:XXXX/ui-voyager`

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

#### Paginated Query
```
query {
  book(first: 1, after: null, last: null, before: null) {
    nodes {
      title
      author {
        name
      }
    }
    pageInfo {
      hasNextPage
      hasPreviousPage
    }
  }
}
```

#### Sorting Query
```
query {
  book(order: {title: ASC}) {
    nodes {
      title
    }
  }
}
```


#### Filtering Query
```
query {
  book(where: {title: {eq: "Foo"}}) {
    nodes {
      title
    }
  }
}
```

#### Mutation
```
mutation Test {
  addBook(input: {
    title: "Test"
  }) {
    book {
      title
    }
  }
}
```