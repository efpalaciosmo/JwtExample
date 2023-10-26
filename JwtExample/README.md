### Database settings
This project uses PostgreSQL as database, we will create a container for that

```shell
podman volume create pg_vol_ecommerce
```

```shell
podman pull postgres:15.4-alpine
```

```shell
podman run -p 5432:5432 \
-e POSTGRES_DB=ecommerce \
-e POSTGRES_USER=postgres \
-e POSTGRES_PASSWORD=PWda234@@dA2 \
-v pg_vol_ecommerce:/var/lib/postgresql/data \
-d postgres:15.4-alpine
```