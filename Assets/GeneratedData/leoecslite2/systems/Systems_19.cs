using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System19 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component261>().Inc<Component174>().Inc<Component288>().Inc<Component291>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component99>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component99>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component366>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component366>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component400>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component400>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component114>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component114>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
