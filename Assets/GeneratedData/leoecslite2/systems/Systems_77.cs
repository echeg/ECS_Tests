using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System77 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component357>().Inc<Component109>().Inc<Component346>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component384>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component384>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component343>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component343>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component90>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component90>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component298>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component298>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
