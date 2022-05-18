# Structured Metrics Metamodel

## Key Features

- The SMM specifies the representation of measures without detailing the representation of the entities measured.

## Domain

### Measures

Measures essentially fall into 2 “categories”:
- **direct measures**, which are measures that are taken directly against a
measurand.
- all others, which we shall call **derived measures**, as their result is based on some other measure(s), direct or
derived. Ultimately, **every measure comes from a direct measure** *(otherwise it might end up triggering a defaultQuery for its
value)*.