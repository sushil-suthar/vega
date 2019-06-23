import { MakeService } from './../services/make.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  vehicle: any = {};
  models: any[];
  constructor(private makeService: MakeService) { }

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes;
      console.log(this.makes);
    });
  }

  onMakeChange() {
    console.log(this.vehicle);
    console.log(this.makes);
    let selectedMake = this.makes.find(m => m.id == this.vehicle.make);
    console.log('selectedMake');
    console.log(selectedMake);
    this.models = selectedMake.modelResources;

  }

}
