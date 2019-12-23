import { Vehicletypes } from "./vehicletypes.model";
export class Vehicle {
    id: Number;
    make: string;
    model: string;
    bodyType: string;
    noOfWeels: Number;
    noOfDoors: Number;
    engine: string;
    vehicleType: Vehicletypes;
}
