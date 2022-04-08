using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System89 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component53>().Inc<Component391>().Inc<Component163>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component347>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component347>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component3>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component3>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component463>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component463>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component53>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component53>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
