import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActivoServiciosComponent } from './activo-servicios.component';

describe('ActivoServiciosComponent', () => {
  let component: ActivoServiciosComponent;
  let fixture: ComponentFixture<ActivoServiciosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActivoServiciosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActivoServiciosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
