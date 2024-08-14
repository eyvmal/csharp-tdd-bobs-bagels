#Domain Models In Here
| Classes  | Methods                                    | Scenario                        | Outputs
|----------|--------------------------------------------|---------------------------------|------------------------
| `Basket` | `addBagel(string bagel)`                   | Add a bagel to the basket       | successful -> true
|          |                                            |                                 | basket is full -> false
| `Basket` | `removeBagel(string bagel)`                | Add a bagel to the basket       | bagel removed -> true
|          |                                            |                                 | bagel not found -> false
| `Basket` | `changeCapacity(int newCapacity)`          | Change the capacity of a basket | void