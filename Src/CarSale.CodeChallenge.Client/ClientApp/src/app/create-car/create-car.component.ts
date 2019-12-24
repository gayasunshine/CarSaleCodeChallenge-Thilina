import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { VehicleService } from '../service/vehicle.service';
import { Vehicletypes } from '../models/vehicletypes.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-create-car',
  templateUrl: './create-car.component.html',
  styleUrls: ['./create-car.component.css']
})
export class CreateCarComponent implements OnInit {

    carForm: FormGroup;
    title = 'Create';
    vehicleId: any;
    error: any;
    VehicleType: Vehicletypes;
    errorMessage: any;


    constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute,
        private _vehicleService: VehicleService, private _router: Router, private toastr: ToastrService) {
        
        //Detramine Vehicle Type
        this.VehicleType = this._avRoute.snapshot.params['vehicleType']
        {
            this.VehicleType = this._avRoute.snapshot.params['vehicleType'];

        }
        this.carForm = this._fb.group({
            vehicleId: 0,
            vType: [''],
            make: ['', [Validators.required]],
            model: ['', [Validators.required]],
            bodyType: ['', [Validators.required]],
            noOfWeels: ['', [Validators.required]],
            noOfDoors: ['', [Validators.required]],
            engine: ['', [Validators.required]],
        })
    }

    ngOnInit() {
    }

    save() {

        if (!this.carForm.valid) {
            return;
        }

        if (this.title === 'Create') {
            this._vehicleService.createVehicle(this.carForm.value)
                .subscribe(success => {
                    this.toastr.success('Vehicle Created Sucsessfully', "ID:" + success);
                }, error => this.toastr.error("Something Went Wrong"));

        }
        
    }

    cancel() {
        this._router.navigate(['/']);
    }

    get make() { return this.carForm.get('make'); }
    get model() { return this.carForm.get('model'); }
    get bodyType() { return this.carForm.get('bodyType'); }
    get noOfWeels() { return this.carForm.get('noOfWeels'); }
    get noOfDoors() { return this.carForm.get('noOfDoors'); }
    get engine() { return this.carForm.get('engine'); }
    get vType() { return this.VehicleType }
    
   

}
