using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System74 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component294>().Inc<Component102>().Inc<Component231>().Inc<Component490>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component337>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component337>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component262>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component262>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component102>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component102>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component336>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component336>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
