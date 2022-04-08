using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System63 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component90>().Inc<Component397>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component227>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component227>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component445>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component445>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component52>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component52>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component163>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component163>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
