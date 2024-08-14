#Domain Models In Here
| Classes  | Methods                                    | Scenario                        | Outputs
|----------|--------------------------------------------|---------------------------------|------------------------
| `Basket` | `addBagel(string bagel)`                   | Add a bagel to the basket       | true if successful
|          |                                            |                                 | false if basket is full
| `Basket` | `removeBagel(string bagel)`                | Add a bagel to the basket       | true if bagel removed
|          |                                            |                                 | false if bagel not found
| `Basket` | `changeCapacity(int newCapacity)`          | Change the capacity of a basket | true if new capacity >= amount bagels
|          |                                            |                                 | false if new capacity < amount bagels