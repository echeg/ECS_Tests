using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System7 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component305>().Inc<Component272>().Inc<Component169>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component359>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component359>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component407>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component407>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component380>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component380>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component483>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component483>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
