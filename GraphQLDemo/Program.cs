using GraphQLDemo.Mutations;
using GraphQLDemo.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();
app.MapGraphQL();

app.UseGraphQLVoyager("/ui-voyager");

app.Run();
