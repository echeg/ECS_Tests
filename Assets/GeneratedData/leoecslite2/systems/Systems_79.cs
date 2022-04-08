using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System79 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component76>().Inc<Component462>().Inc<Component139>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component396>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component396>().Get(entity);
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
   if (_world.GetPool<Component426>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component426>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component261>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component261>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
