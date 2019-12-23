import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map, catchError } from 'rxjs/operators';
import { Vehicle } from 'src/app/models/vehicle.model';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

    myAppUrl = '';

    constructor(private _http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.myAppUrl = baseUrl + 'api/VehicleCreator/';
    }

    createVehicle(vehicle: Observable<Vehicle>) {
        return this._http.post(this.myAppUrl + 'CreateVehicle', vehicle)
            .pipe(map(
                response => {
                    return response
                }));
    }

    
}
