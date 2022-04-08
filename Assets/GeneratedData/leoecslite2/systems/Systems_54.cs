using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System54 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component332>().Inc<Component25>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component55>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component55>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component378>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component378>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component264>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component264>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component80>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component80>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
