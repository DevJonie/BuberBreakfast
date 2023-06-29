# Create Breakfast

## Create Breakfast Request

``` POST /breakfasts ```

```json
{
  "name": "Vegan Sunshine",
  "description": "Vegan Sunshine! Join us for a healty vegan breakfast!",
  "startDateTime": "2023-06-28T08:00:00",
  "endDateTime": "2023-06-28T11:00:00",
  "savory": [
    "Oatmeal",
    "Salad"
  ],
  "sweet": [
    "Cookie"
  ],
}
```


## Create Breakfast response

``` 201 Created ```
``` Location {{host}}/breakfasts/{{id}} ```

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "name": "Vegan Sunshine",
  "description": "Vegan Sunshine! Join us for a healty vegan breakfast!",
  "startDateTime": "2023-06-28T08:00:00",
  "endDateTime": "2023-06-28T11:00:00",
  "savory": [
    "Oatmeal",
    "Salad"
  ],
  "sweet": [
    "Cookie"
  ],
}
```


# Get Breakfast

## Get Breakfast Request

``` GET /breakfasts/{{id}} ```

## Get Breakfast Response

``` 200 OK ```

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "name": "Vegan Sunshine",
  "description": "Vegan Sunshine! Join us for a healty vegan breakfast!",
  "startDateTime": "2023-06-28T08:00:00",
  "endDateTime": "2023-06-28T11:00:00",
  "savory": [
    "Oatmeal",
    "Salad"
  ],
  "sweet": [
    "Cookie"
  ],
}
```

# Update Breakfast

## Update Breakfast Reuest

``` PUT /breakfasts/{{id}} ```

```json
{
  "name": "Vegan Sunshine",
  "description": "Vegan Sunshine! Join us for a healty vegan breakfast!",
  "startDateTime": "2023-06-28T08:00:00",
  "endDateTime": "2023-06-28T11:00:00",
  "savory": [
    "Oatmeal",
    "Salad"
  ],
  "sweet": [
    "Cookie"
  ],
}
```

## Update Breakfast Response

``` 204 No Content ```
or
``` 200 OK ```
``` Location {{host}}/breakfast/{{id}} ```


# Delete Breakfast

## Delete Breakfast Request

``` DELETE /breakfasts/{{id}} ```

## Delete Breakfast Response

``` 204 No Content ```