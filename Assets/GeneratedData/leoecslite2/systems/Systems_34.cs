using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System34 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component450>().Inc<Component467>().Inc<Component155>().Inc<Component407>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component188>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component188>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component217>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component217>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component379>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component379>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component362>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component362>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
