using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System10 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component289>().Inc<Component279>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component437>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component437>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component97>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component97>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component159>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component159>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component158>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component158>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
