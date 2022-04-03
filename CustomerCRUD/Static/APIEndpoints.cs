namespace CustomerCRUD.Static;
internal static class APIEndpoints
{
#if DEBUG
  private const string ServerBaseUrl = "https://localhost:7130";
#else
  private const string ServerBaseUrl = "https://wasmwithaspnetcore-server.azurewebsites.net";
#endif

  internal const string PostsAll = $"{ServerBaseUrl}/posts/all";
  internal const string PostsCreate = $"{ServerBaseUrl}/posts/create";
  internal static string PostsById(int id) => $"{ServerBaseUrl}/posts/by-id/{id}";
  internal static string PostsUpdate(int id) => $"{ServerBaseUrl}/posts/udpate/{id}";
  internal static string PostsDelete(int id) => $"{ServerBaseUrl}/posts/delete/{id}";
}
