// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/customers.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class Customer
  {
    static readonly string __ServiceName = "Customer";

    static readonly grpc::Marshaller<global::GrpcServer.CustomerLookUpModel> __Marshaller_CustomerLookUpModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.CustomerLookUpModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.CustomerModel> __Marshaller_CustomerModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.CustomerModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.NewCustomerRequest> __Marshaller_NewCustomerRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.NewCustomerRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.CustomerLookUpModel, global::GrpcServer.CustomerModel> __Method_GetCustomerInfo = new grpc::Method<global::GrpcServer.CustomerLookUpModel, global::GrpcServer.CustomerModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerInfo",
        __Marshaller_CustomerLookUpModel,
        __Marshaller_CustomerModel);

    static readonly grpc::Method<global::GrpcServer.NewCustomerRequest, global::GrpcServer.CustomerModel> __Method_GetNewCustomer = new grpc::Method<global::GrpcServer.NewCustomerRequest, global::GrpcServer.CustomerModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetNewCustomer",
        __Marshaller_NewCustomerRequest,
        __Marshaller_CustomerModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.CustomersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Customer</summary>
    public partial class CustomerClient : grpc::ClientBase<CustomerClient>
    {
      /// <summary>Creates a new client for Customer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CustomerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Customer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CustomerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CustomerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CustomerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServer.CustomerModel GetCustomerInfo(global::GrpcServer.CustomerLookUpModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.CustomerModel GetCustomerInfo(global::GrpcServer.CustomerLookUpModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerInfo, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CustomerModel> GetCustomerInfoAsync(global::GrpcServer.CustomerLookUpModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CustomerModel> GetCustomerInfoAsync(global::GrpcServer.CustomerLookUpModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerInfo, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcServer.CustomerModel> GetNewCustomer(global::GrpcServer.NewCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNewCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcServer.CustomerModel> GetNewCustomer(global::GrpcServer.NewCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetNewCustomer, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CustomerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerClient(configuration);
      }
    }

  }
}
#endregion
