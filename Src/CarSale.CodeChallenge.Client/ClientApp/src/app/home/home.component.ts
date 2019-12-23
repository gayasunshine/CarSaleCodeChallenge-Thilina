import { Component,OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Vehicletypes } from '../models/vehicletypes.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
    createVehicleForm: FormGroup;
    VehicleTypes = Vehicletypes;
    vehicleType: string
    
    constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute, private _router: Router) {
        this.createVehicleForm = this._fb.group({
            vehicletype: ['', [Validators.required]],

        })

    }

    

    ngOnInit() {
        //this.list = this.VehicleTypes.values();
    };

    create() {
        this.vehicleType = this.vehicletype.value;
        this._router.navigate(['/create-car', this.vehicleType]);
    }
    get vehicletype() { return this.createVehicleForm.get('vehicletype'); }
   
}
