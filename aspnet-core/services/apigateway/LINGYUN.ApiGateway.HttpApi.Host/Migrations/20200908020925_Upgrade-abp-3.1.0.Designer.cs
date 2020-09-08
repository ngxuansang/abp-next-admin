﻿// <auto-generated />
using System;
using LINGYUN.ApiGateway.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

namespace LINGYUN.ApiGateway.HttpApi.Host.Migrations
{
    [DbContext(typeof(HttpApiHostMigrationsDbContext))]
    [Migration("20200908020925_Upgrade-abp-3.1.0")]
    partial class Upgradeabp310
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.AggregateReRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aggregator")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("AppId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<long>("ReRouteId")
                        .HasColumnType("bigint");

                    b.Property<bool>("ReRouteIsCaseSensitive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("ReRouteKeys")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("UpstreamHost")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("UpstreamHttpMethod")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("UpstreamPathTemplate")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("AppApiGatewayAggregate");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.AggregateReRouteConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AggregateReRouteId")
                        .HasColumnType("int");

                    b.Property<string>("JsonPath")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("Parameter")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<long>("ReRouteId")
                        .HasColumnType("bigint");

                    b.Property<string>("ReRouteKey")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AggregateReRouteId");

                    b.ToTable("AppApiGatewayAggregateConfig");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.AuthenticationOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AllowedScopes")
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("AuthenticationProviderKey")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<long>("ReRouteId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AppApiGatewayAuthOptions");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.CacheOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("ReRouteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Region")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<int?>("TtlSeconds")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AppApiGatewayCacheOptions");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.DynamicReRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AppId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("DownstreamHttpVersion")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<long>("DynamicReRouteId")
                        .HasColumnType("bigint");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("AppApiGatewayDynamicReRoute");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AppId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("DownstreamHttpVersion")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("DownstreamScheme")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<long>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("RequestIdKey")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("AppApiGatewayGlobalConfiguration");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.Headers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<long>("ReRouteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AppApiGatewayHeaders");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.HostAndPort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<int?>("Port")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<long>("ReRouteId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("AppApiGatewayHostAndPort");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.HttpHandlerOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AllowAutoRedirect")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<int?>("MaxConnectionsPerServer")
                        .HasColumnType("int");

                    b.Property<long?>("ReRouteId")
                        .HasColumnType("bigint");

                    b.Property<bool>("UseCookieContainer")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("UseProxy")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("UseTracing")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AppApiGatewayHttpOptions");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.LoadBalancerOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Expiry")
                        .HasColumnType("int");

                    b.Property<long?>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("Key")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<long?>("ReRouteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AppApiGatewayBalancerOptions");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.QoSOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DurationOfBreak")
                        .HasColumnType("int");

                    b.Property<int?>("ExceptionsAllowedBeforeBreaking")
                        .HasColumnType("int");

                    b.Property<long?>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ReRouteId")
                        .HasColumnType("bigint");

                    b.Property<int?>("TimeoutValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AppApiGatewayQoSOptions");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.RateLimitOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClientIdHeader")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50)
                        .HasDefaultValue("ClientId");

                    b.Property<bool>("DisableRateLimitHeaders")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("HttpStatusCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(429);

                    b.Property<long>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("QuotaExceededMessage")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("RateLimitCounterPrefix")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50)
                        .HasDefaultValue("ocelot");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("AppApiGatewayRateLimitOptions");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.RateLimitRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClientWhitelist")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<long?>("DynamicReRouteId")
                        .HasColumnType("bigint");

                    b.Property<bool>("EnableRateLimiting")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("Limit")
                        .HasColumnType("bigint");

                    b.Property<string>("Period")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<double?>("PeriodTimespan")
                        .HasColumnType("double");

                    b.Property<long?>("ReRouteId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DynamicReRouteId")
                        .IsUnique();

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AppApiGatewayRateLimitRule");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.ReRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AddClaimsToRequest")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("AddHeadersToRequest")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("AddQueriesToRequest")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("AppId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("ChangeDownstreamPathTemplate")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<bool>("DangerousAcceptAnyServerCertificateValidator")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("DelegatingHandlers")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("DownstreamHeaderTransform")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("DownstreamHostAndPorts")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("DownstreamHttpMethod")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("DownstreamHttpVersion")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("DownstreamPathTemplate")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("DownstreamScheme")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Key")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<long>("ReRouteId")
                        .HasColumnType("bigint");

                    b.Property<bool>("ReRouteIsCaseSensitive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ReRouteName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("RequestIdKey")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("RouteClaimsRequirement")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("ServiceName")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("ServiceNamespace")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<int?>("Timeout")
                        .HasColumnType("int");

                    b.Property<string>("UpstreamHeaderTransform")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("UpstreamHost")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("UpstreamHttpMethod")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("UpstreamPathTemplate")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AppId", "DownstreamPathTemplate", "UpstreamPathTemplate")
                        .IsUnique();

                    b.ToTable("AppApiGatewayReRoute");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.RouteGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AppId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("AppIpAddress")
                        .IsRequired()
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("AppName")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AppId", "AppName", "AppIpAddress");

                    b.ToTable("AppApiGatewayRouteGroup");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.SecurityOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IPAllowedList")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("IPBlockedList")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<long>("ReRouteId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ReRouteId")
                        .IsUnique();

                    b.ToTable("AppApiGatewaySecurityOptions");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.ServiceDiscoveryProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConfigurationKey")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("Host")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<long>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("Namespace")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<int?>("PollingInterval")
                        .HasColumnType("int");

                    b.Property<int?>("Port")
                        .HasColumnType("int");

                    b.Property<string>("Scheme")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Token")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("Type")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("AppApiGatewayDiscovery");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.AggregateReRouteConfig", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.AggregateReRoute", null)
                        .WithMany("ReRouteKeysConfig")
                        .HasForeignKey("AggregateReRouteId");
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.AuthenticationOptions", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRoute")
                        .WithOne("AuthenticationOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.AuthenticationOptions", "ReRouteId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.CacheOptions", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRoute")
                        .WithOne("CacheOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.CacheOptions", "ReRouteId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.HttpHandlerOptions", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "GlobalConfiguration")
                        .WithOne("HttpHandlerOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.HttpHandlerOptions", "ItemId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRoute")
                        .WithOne("HttpHandlerOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.HttpHandlerOptions", "ReRouteId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.LoadBalancerOptions", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "GlobalConfiguration")
                        .WithOne("LoadBalancerOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.LoadBalancerOptions", "ItemId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRoute")
                        .WithOne("LoadBalancerOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.LoadBalancerOptions", "ReRouteId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.QoSOptions", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "GlobalConfiguration")
                        .WithOne("QoSOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.QoSOptions", "ItemId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRoute")
                        .WithOne("QoSOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.QoSOptions", "ReRouteId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.RateLimitOptions", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "GlobalConfiguration")
                        .WithOne("RateLimitOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.RateLimitOptions", "ItemId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.RateLimitRule", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.DynamicReRoute", "DynamicReRoute")
                        .WithOne("RateLimitRule")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.RateLimitRule", "DynamicReRouteId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.DynamicReRoute", "DynamicReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRoute")
                        .WithOne("RateLimitOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.RateLimitRule", "ReRouteId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.SecurityOptions", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRoute")
                        .WithOne("SecurityOptions")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.SecurityOptions", "ReRouteId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.ReRoute", "ReRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LINGYUN.ApiGateway.Ocelot.ServiceDiscoveryProvider", b =>
                {
                    b.HasOne("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "GlobalConfiguration")
                        .WithOne("ServiceDiscoveryProvider")
                        .HasForeignKey("LINGYUN.ApiGateway.Ocelot.ServiceDiscoveryProvider", "ItemId")
                        .HasPrincipalKey("LINGYUN.ApiGateway.Ocelot.GlobalConfiguration", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
