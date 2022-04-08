using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System17 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component323>().Inc<Component261>().Inc<Component466>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component320>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component320>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component444>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component444>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component307>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component307>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component9>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component9>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
