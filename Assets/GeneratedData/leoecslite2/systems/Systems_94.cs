using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System94 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component235>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component156>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component156>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component47>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component47>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component45>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component45>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component491>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component491>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
