using Oakton;
using Order.Create;
using Wolverine;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("order_db");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// integrate Wolverine
builder.Host.UseWolverine();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("order/create", (CreateOrder request, IMessageBus bus) => bus.InvokeAsync(request));

return await app.RunOaktonCommands(args);

