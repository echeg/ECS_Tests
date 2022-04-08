using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System6 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component117>().Inc<Component259>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component27>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component27>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component36>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component36>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component248>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component248>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component38>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component38>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
